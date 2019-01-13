using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TeduShop.Data.Infrastructure;
using TeduShop.Data.Repositories;
using TeduShop.Model.Models;

namespace TeduShop.UnitTest.RepositoryTest
{
    [TestClass] //thuoctinh
    public class PostCategoryRepositoryTest
    {
        //Khai báo thì dùng Interface
        IDbFactory dbFactory;
        IPostCategoryRepository objRepository;
        IUnitOfWork unitOfWork;
        //Cần 3 đối tượng này để tương tác với cơ sở dữ liệu

        [TestInitialize]
        public void InInitialize()
        {
            //khởi tạo thì dùng Infrastructure
            dbFactory = new DbFactory();
            objRepository = new PostCategoryRepository(dbFactory);//Infrastructure cần 1 dbFactory
            unitOfWork = new UnitOfWork(dbFactory);

        }
        [TestMethod]
        public void PostCategory_Repository_GetAll()
        {
            var list = objRepository.GetAll().ToList();
            Assert.AreEqual(3, list.Count);
        }

        [TestMethod]
        public void PostCategory_Repository_Create()
        {
            PostCategory category = new PostCategory();
            category.Name = "Test Category";
            category.Alias = "Test-Category";
            category.Status = true;

            var result= objRepository.Add(category);
            unitOfWork.Commit();

            Assert.IsNotNull(result);
            Assert.AreEqual(3, result.ID);
        }
    }
}
