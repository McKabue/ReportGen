using AutoDocx.Tools.Interfaces;
using AutoDocx.Tools.Models;
using AutoDocx.Tools.Repositories;
using System;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Data.Entity.Migrations;

namespace AutoDocx.Tools.DAL
{
    public class UnitOfWork : IDisposable
    {
        private readonly DatabaseContext context;
        private IBaseRepository<BookMark> bookMarkRepository;
        private IBaseRepository<BookMarkType> bookMarkTypeRepository;
        private IBaseRepository<AutoDocument> autoDocumentRepository;
        private IBaseRepository<Template> templateRepository;
        private IBaseRepository<BookMarkData> bookMarkDataRepository;

        public UnitOfWork()
        {
            //context = new DatabaseContext();
            context = ThisAddIn._databaseContext;
        }




        public IBaseRepository<BookMark> BookMarkRepository
        {
            get
            {

                if (this.bookMarkRepository == null)
                {
                    this.bookMarkRepository = new BaseRepository<BookMark>(context);
                }
                return bookMarkRepository;
            }
        }

        public IBaseRepository<BookMarkType> BookMarkTypeRepository
        {
            get
            {

                if (this.bookMarkTypeRepository == null)
                {
                    this.bookMarkTypeRepository = new BaseRepository<BookMarkType>(context);
                }
                return bookMarkTypeRepository;
            }
        }

        public IBaseRepository<AutoDocument> AutoDocumentRepository
        {
            get
            {

                if (this.autoDocumentRepository == null)
                {
                    this.autoDocumentRepository = new BaseRepository<AutoDocument>(context);
                }
                return autoDocumentRepository;
            }
        }

        public IBaseRepository<Template> TemplateRepository
        {
            get
            {

                if (this.templateRepository == null)
                {
                    this.templateRepository = new BaseRepository<Template>(context);
                }
                return templateRepository;
            }
        }

        public IBaseRepository<BookMarkData> BookMarkDataRepository
        {
            get
            {

                if (this.bookMarkDataRepository == null)
                {
                    this.bookMarkDataRepository = new BaseRepository<BookMarkData>(context);
                }
                //return context.Entry<BookMarkData>(context.BookMarkDatas).Reload();
                return bookMarkDataRepository;
            }
        }

        public void Seed()
        {
            if (!context.BookMarkTypes.Any())
            {
                context.BookMarkTypes.AddOrUpdate(
                    new BookMarkType { BookMarkTypeID = "1", BookMarkTypeString = "PlainText" },
                    new BookMarkType { BookMarkTypeID = Guid.NewGuid().ToString("D"), BookMarkTypeString = "DataTime" }
                );
               this.Save();
            }
        }

        public void Save()
        {
           context.SaveChanges();
           context.RefreshAllEntites(RefreshMode.StoreWins);
        }










        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
