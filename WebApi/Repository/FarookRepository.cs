using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;
using WebApi.Models.FarookModel;

namespace WebApi.Repository.FarookRepository
{
    public interface IFarookRepository
    {
        List<FarookModel> GetAll();
        FarookModel FindById(int id);
        FarookModel Add(FarookModel farookModel);
        FarookModel Update(FarookModel farookModel);
        int Remove(int id);
    }
    public class FarookRepository : IFarookRepository
    {

        public List<FarookModel> GetAll()
        {
         
            // Debug.WriteLine(_products);

            // Now use database data but i lazy connect database i'll mock data
            var data = DataGetAllFarook();
            return data;
        }

        public FarookModel FindById(int id)
        {
            var data = FindByFarookId(id);
            return data;
        }
        public FarookModel Add(FarookModel farookModel)
        {
            var data = AddFarookData(farookModel);
            return data;
        }

        public FarookModel Update(FarookModel farookModel)
        {
            var data = UpdateDataFarook(farookModel);
            return data;
        }

        public int Remove(int id)
        {
            var data = RemoveFarookdata(id);
            return data;
        }




        private List<FarookModel> DataGetAllFarook()
        {
            var listFarook = new List<FarookModel> {
                new FarookModel { Id = 1, Name = "Farook1", Address = "Puhket", Email ="Farook@Gmail.com", Tel = "082-111562818"},
                new FarookModel { Id = 2, Name = "Farook2", Address = "Puhket1", Email ="Farook1@Gmail.com", Tel = "082-111562818"},
                new FarookModel { Id = 3, Name = "Farook3", Address = "Puhket2", Email ="Farook2@Gmail.com", Tel = "082-111562818"},
                new FarookModel { Id = 4, Name = "Farook4", Address = "Puhket3", Email ="Farook3@Gmail.com", Tel = "082-111562818"},
                new FarookModel { Id = 5, Name = "Farook5", Address = "Puhket3", Email ="Farook4@Gmail.com", Tel = "082-111562818"},
            };
            return listFarook;
        }
        private FarookModel FindByFarookId(int id)
        {
            var data = DataGetAllFarook();
            var findData = data.FirstOrDefault(d => d.Id == id);
            return findData;
        }
        private FarookModel AddFarookData(FarookModel farookModel)
        {
            if (farookModel != null)
            {
                var data = new FarookModel();
                data.Id = farookModel.Id;
                data.Name = farookModel.Name;
                data.Tel = farookModel.Tel;
                data.Email = farookModel.Email;
            }
            return farookModel;
        }
        private FarookModel UpdateDataFarook(FarookModel farookModel)
        {

            if (farookModel is null)
            {
                 throw new Exception("Can't Update");
            }
            var data = FindByFarookId(farookModel.Id);
            data = farookModel;
            return data;


        }

        private int RemoveFarookdata(int id)
        {
            if (id != 0)
            {
                var data = FindByFarookId(id);
                data.Id = id;
                return 1;
            }
            return 0;
        }

    }

}
