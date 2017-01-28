#region Using Namespaces...

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data.Entity.Validation;
using Tracktor.DAL.GenericRepository;
using Tracktor.DAL.Database;
using Tracktor.DAL.Repositories;

#endregion

namespace Tracktor.DAL.UnitOfWork
{
    /// <summary>
    /// Unit of Work class responsible for DB transactions
    /// </summary>
    public class UnitOfWork : IDisposable
    {
        #region Private member variables...

        private TracktorDb _context = null;
        private CategoryRepository _categoryRepository;
        private CommentRepository _commentRepository;
        private InfoRepository _infoRepository;
        private PlaceRepository _placeRepository;
        private ReputationCommentRepository _reputationCommentRepository;
        private ReputationInfoRepository _reputationInfoRepository;
        private UserRepository _userRepository;
        private UserTypeRepository _userTypeRepository;
        #endregion

        public UnitOfWork()
        {
            _context = new TracktorDb();
        }

        #region Public Repository Creation properties...
        /// <summary>
        /// Get/Set Property for category repository.
        /// </summary>
        public CategoryRepository CategoryRepository
        {
            get
            {
                if (this._categoryRepository == null)
                    this._categoryRepository = new CategoryRepository(_context);
                return _categoryRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for comment repository.
        /// </summary>
        public CommentRepository CommentRepository
        {
            get
            {
                if (this._commentRepository == null)
                    this._commentRepository = new CommentRepository(_context);
                return _commentRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for info repository.
        /// </summary>
        public InfoRepository InfoRepository
        {
            get
            {
                if (this._infoRepository == null)
                    this._infoRepository = new InfoRepository(_context);
                return _infoRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for place repository.
        /// </summary>
        public PlaceRepository PlaceRepository
        {
            get
            {
                if (this._placeRepository == null)
                    this._placeRepository = new PlaceRepository(_context);
                return _placeRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for reputationComment repository.
        /// </summary>
        public ReputationCommentRepository ReputationCommentRepository
        {
            get
            {
                if (this._reputationCommentRepository == null)
                    this._reputationCommentRepository = new ReputationCommentRepository(_context);
                return _reputationCommentRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for reputationInfo repository.
        /// </summary>
        public ReputationInfoRepository ReputationInfoRepository
        {
            get
            {
                if (this._reputationInfoRepository == null)
                    this._reputationInfoRepository = new ReputationInfoRepository(_context);
                return _reputationInfoRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for user repository.
        /// </summary>
        public UserRepository UserRepository
        {
            get
            {
                if (this._userRepository == null)
                    this._userRepository = new UserRepository(_context);
                return _userRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for userType repository.
        /// </summary>
        public UserTypeRepository UserTypeRepository
        {
            get
            {
                if (this._userTypeRepository == null)
                    this._userTypeRepository = new UserTypeRepository(_context);
                return _userTypeRepository;
            }
        }
        #endregion

        #region Public member methods...
        /// <summary>
        /// Save method.
        /// </summary>
        public void Save()
        {
            try
            {
                _context.SaveChanges();
            }
            catch (DbEntityValidationException e)
            {

                var outputLines = new List<string>();
                foreach (var eve in e.EntityValidationErrors)
                {
                    outputLines.Add(string.Format(
                        "{0}: Entity of type \"{1}\" in state \"{2}\" has the following validation errors:", DateTime.Now,
                        eve.Entry.Entity.GetType().Name, eve.Entry.State));
                    foreach (var ve in eve.ValidationErrors)
                    {
                        outputLines.Add(string.Format("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage));
                    }
                }
                System.IO.File.AppendAllLines(@"C:\errors.txt", outputLines);

                throw e;
            }

        }

        #endregion

        #region Implementing IDiosposable...

        #region private dispose variable declaration...
        private bool disposed = false;
        #endregion

        /// <summary>
        /// Protected Virtual Dispose method
        /// </summary>
        /// <param name="disposing"></param>
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    Debug.WriteLine("UnitOfWork is being disposed");
                    _context.Dispose();
                }
            }
            this.disposed = true;
        }

        /// <summary>
        /// Dispose method
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        #endregion
    }
}