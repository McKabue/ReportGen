using ReportGen.Tools.Interfaces;
using ReportGen.Tools.Models;
using ReportGen.Tools.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ReportGen.Tools.DAL
{
    public class UnitOfWork
    {
        private readonly DatabaseContext context;
        private IBaseRepository<BookMark> bookMarkRepository;
        private IBaseRepository<BookMarkType> bookMarkTypeRepository { get; set; }

        public UnitOfWork()
        {
            context = new DatabaseContext();
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

       

        public int Save()
        {
           return context.SaveChanges();
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
