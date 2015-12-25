using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutoDocx.Tools
{
    public static class Extentions
    {
        public static IEnumerable<TreeNode> Descendants(this TreeNodeCollection c)
        {
            foreach(var node in c.OfType<TreeNode>())
            {
                yield return node;

                foreach (var child in node.Nodes.Descendants())
                {
                    yield return child;
                }
            }
        }


        public static void ForEach<T>(this IEnumerable<T> items, Action<T> action)
        {
            foreach (var item in items)
            {
                action(item);
            }
        }


        public static bool IsNullOrEmpty<T>(this IEnumerable<T> enumerable)
        {
            return enumerable == null || !enumerable.Any();
        }


        //http://stackoverflow.com/questions/20270599/entity-framework-refresh-context
        //https://msdn.microsoft.com/en-us/library/system.data.entity.infrastructure.dbentityentry.reload(v=vs.113).aspx#M:System.Data.Entity.Infrastructure.DbEntityEntry.Reload
        public static void ReloadEntity<TEntity>(this DbContext context, TEntity entity) where TEntity : class
        {
            context.Entry(entity).Reload();
        }

        public static void ReloadNavigationProperty<TEntity, TElement>(this DbContext context, TEntity entity, Expression<Func<TEntity, ICollection<TElement>>> navigationProperty) where TEntity : class where TElement : class
        {
            context.Entry(entity).Collection<TElement>(navigationProperty).Query();
        }


        /// <summary>
        /// Refresh non-detached entities
        /// </summary>
        /// <param name="dbContext">context of the entities</param>
        /// <param name="refreshMode">store or client wins</param>
        /// <param name="entityType">when specified only entities of that type are refreshed. when null all non-detached entities are modified</param>
        /// <returns></returns>
        public static DbContext RefreshEntites(this DbContext dbContext, RefreshMode refreshMode, Type entityType)
        {
            //https://christianarg.wordpress.com/2013/06/13/entityframework-refreshall-loaded-entities-from-database/
            var objectContext = ((IObjectContextAdapter)dbContext).ObjectContext;
            var refreshableObjects = objectContext.ObjectStateManager
                .GetObjectStateEntries(EntityState.Added | EntityState.Deleted | EntityState.Modified | EntityState.Unchanged)
                .Where(x => entityType == null || x.Entity.GetType() == entityType)
                .Where(entry => entry.EntityKey != null)
                .Select(e => e.Entity)
                .ToArray();

            objectContext.Refresh(RefreshMode.StoreWins, refreshableObjects);

            return dbContext;
        }

        public static DbContext RefreshAllEntites(this DbContext dbContext, RefreshMode refreshMode)
        {
            return RefreshEntites(dbContext: dbContext, refreshMode: refreshMode, entityType: null); //null entityType is a wild card
        }

        public static DbContext RefreshEntites<TEntity>(this DbContext dbContext, RefreshMode refreshMode)
        {
            return RefreshEntites(dbContext: dbContext, refreshMode: refreshMode, entityType: typeof(TEntity));
        }
    }



    public static class TreeViewExtensions
    {
        private const int TVIF_STATE = 0x8;
        private const int TVIS_STATEIMAGEMASK = 0xF000;
        private const int TV_FIRST = 0x1100;
        private const int TVM_SETITEM = TV_FIRST + 63;

        [StructLayout(LayoutKind.Sequential, Pack = 8, CharSet = CharSet.Auto)]
        private struct TVITEM
        {
            public int mask;
            public IntPtr hItem;
            public int state;
            public int stateMask;
            [MarshalAs(UnmanagedType.LPTStr)]
            public string lpszText;
            public int cchTextMax;
            public int iImage;
            public int iSelectedImage;
            public int cChildren;
            public IntPtr lParam;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(IntPtr hWnd, int Msg, IntPtr wParam,
                                                 ref TVITEM lParam);

        /// <summary>
        /// Hides the checkbox for the specified node on a TreeView control.
        /// </summary>
        public static void HideCheckBox(this TreeNode node)
        {
            TVITEM tvi = new TVITEM();
            tvi.hItem = node.Handle;
            tvi.mask = TVIF_STATE;
            tvi.stateMask = TVIS_STATEIMAGEMASK;
            tvi.state = 0;
            SendMessage(node.TreeView.Handle, TVM_SETITEM, IntPtr.Zero, ref tvi);
        }
    }
}
