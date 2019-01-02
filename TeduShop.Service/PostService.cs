﻿using System;
using System.Collections.Generic;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;
using System.Linq;

namespace TeduShop.Service
{
    public interface IPostService
    {
        void Add(Post post);

        void Update(Post post);

        void Detele(int id);

        IEnumerable<Post> GetAll();

        IEnumerable<Post> GetAllPaging(int page, int pagesize, out int totalRow);
        IEnumerable<Post> GetAllByCategoryPaging(int categoryId,int page, int pagesize, out int totalRow);

        Post GetById(int id);

        IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pagesize, out int totalRow);

        void SaveChanges();
    }

    public class PostService : IPostService
    {
        IPostRepository _postRepository;
        IUnitOfWork _unitOfWork;
        public PostService(IPostRepository postRepository,IUnitOfWork unitOfWork)
        {
            this._postRepository = postRepository;
            this._unitOfWork = unitOfWork;

        }
        public void Add(Post post)
        {
            _postRepository.Add(post);
        }

        public void Detele(int id)
        {
            _postRepository.Delete(id);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postRepository.GetAll(new string[] { "PostCategory"});
        }

        public IEnumerable<Post> GetAllByCategoryPaging(int categoryId, int page, int pagesize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status && x.CategoryID == categoryId, out totalRow, page, pagesize, new string[] { "PostCategory" });
        }

        public IEnumerable<Post> GetAllByTagPaging(string tag,int page, int pagesize, out int totalRow)
        {
            //TODO: select all post by tag
            return _postRepository.GetMultiPaging(x => x.Status,out totalRow,page,pagesize);
        }

        public IEnumerable<Post> GetAllPaging(int page, int pagesize, out int totalRow)
        {
            return _postRepository.GetMultiPaging(x => x.Status, out totalRow, page, pagesize);
        }

        public Post GetById(int id)
        {
            return _postRepository.GetSingleById(id);
        }

        public void SaveChanges()
        {
            _unitOfWork.Commit();
        }

        public void Update(Post post)
        {
            _postRepository.Update(post);
        }
    }
}