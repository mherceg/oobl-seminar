﻿#region Using Namespaces...

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Data.Entity.Validation;
using Tracktor.DAL.GenericRepository;
using Tracktor.DAL.Database;

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
        private GenericRepository<Category> _categoryRepository;
        private GenericRepository<Comment> _commentRepository;
        private GenericRepository<FavoritePlace> _favoritePlaceRepository;
        private GenericRepository<Info> _infoRepository;
        private GenericRepository<Place> _placeRepository;
        private GenericRepository<ReputationComment> _reputationCommentRepository;
        private GenericRepository<ReputationInfo> _reputationInfoRepository;
        private GenericRepository<Sponsorship> _sponsorshipRepository;
        private GenericRepository<User> _userRepository;
        private GenericRepository<UserType> _userTypeRepository;
        #endregion

        public UnitOfWork()
        {
            _context = new TracktorDb();
        }

        #region Public Repository Creation properties...
        /// <summary>
        /// Get/Set Property for category repository.
        /// </summary>
        public GenericRepository<Category> CategoryRepository
        {
            get
            {
                if (this._categoryRepository == null)
                    this._categoryRepository = new GenericRepository<Category>(_context);
                return _categoryRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for comment repository.
        /// </summary>
        public GenericRepository<Comment> CommentRepository
        {
            get
            {
                if (this._commentRepository == null)
                    this._commentRepository = new GenericRepository<Comment>(_context);
                return _commentRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for favoritePlace repository.
        /// </summary>
        public GenericRepository<FavoritePlace> FavoritePlaceRepository
        {
            get
            {
                if (this._favoritePlaceRepository == null)
                    this._favoritePlaceRepository = new GenericRepository<FavoritePlace>(_context);
                return _favoritePlaceRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for info repository.
        /// </summary>
        public GenericRepository<Info> InfoRepository
        {
            get
            {
                if (this._infoRepository == null)
                    this._infoRepository = new GenericRepository<Info>(_context);
                return _infoRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for place repository.
        /// </summary>
        public GenericRepository<Place> PlaceRepository
        {
            get
            {
                if (this._placeRepository == null)
                    this._placeRepository = new GenericRepository<Place>(_context);
                return _placeRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for reputationComment repository.
        /// </summary>
        public GenericRepository<ReputationComment> ReputationCommentRepository
        {
            get
            {
                if (this._reputationCommentRepository == null)
                    this._reputationCommentRepository = new GenericRepository<ReputationComment>(_context);
                return _reputationCommentRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for reputationInfo repository.
        /// </summary>
        public GenericRepository<ReputationInfo> ReputationInfoRepository
        {
            get
            {
                if (this._reputationInfoRepository == null)
                    this._reputationInfoRepository = new GenericRepository<ReputationInfo>(_context);
                return _reputationInfoRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for sponsorship repository.
        /// </summary>
        public GenericRepository<Sponsorship> SponsorshipRepository
        {
            get
            {
                if (this._sponsorshipRepository == null)
                    this._sponsorshipRepository = new GenericRepository<Sponsorship>(_context);
                return _sponsorshipRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for user repository.
        /// </summary>
        public GenericRepository<User> UserRepository
        {
            get
            {
                if (this._userRepository == null)
                    this._userRepository = new GenericRepository<User>(_context);
                return _userRepository;
            }
        }

        /// <summary>
        /// Get/Set Property for userType repository.
        /// </summary>
        public GenericRepository<UserType> UserTypeRepository
        {
            get
            {
                if (this._userTypeRepository == null)
                    this._userTypeRepository = new GenericRepository<UserType>(_context);
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