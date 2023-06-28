using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Constant;
using WebApi.Models.FarookModel;
using WebApi.Models.ResponseModel;
using WebApi.Repository.FarookRepository;
using WebApi.Utils;

namespace WebApi.Service.FarookService
{
    public interface IFarookService
    {
        List<FarookModel> GetAll();
        FarookModel FindById(int id);
        FarookModel Add(FarookModel farookModel);
        FarookModel Update(FarookModel farookModel);
        int Remove(int id);
    }
    public class FarookService : IFarookService
    {
        private readonly IFarookRepository _farookRepository;
        public FarookService(IFarookRepository farookRepository)
        {
            _farookRepository = farookRepository;
        }

        public List<FarookModel> GetAll()
        {
            // throw new ExceptionHandling((int)HttpStatusCodes.NotFound, "faroooksdsdsdsdsadsadsadsadsad");
            var action = _farookRepository.GetAll();
            return action;
        }
        public FarookModel FindById(int id)
        {
            var action = _farookRepository.FindById(id);
            return action;
        }
        public FarookModel Add(FarookModel farookModel)
        {
            var action = _farookRepository.Add(farookModel);
            return action;
        }
        public FarookModel Update(FarookModel farookModel)
        {
            var action = _farookRepository.Update(farookModel);
            return action;
        }
        public int Remove(int id)
        {
            var action = _farookRepository.Remove(id);
            return action;
        }
    }
}
