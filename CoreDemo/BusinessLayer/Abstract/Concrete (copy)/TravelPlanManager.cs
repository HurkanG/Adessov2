using System;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract.Concrete
{
    public class TravelPlanManager : ITravelPlanService
    {
        ITravelPlanDal _travelPan;

        public TravelPlanManager(ITravelPlanDal travelPlanDal)
        {
            _travelPan = travelPlanDal;
        }

        public TravelPlan GetByDate(DateTime travelDate)
        {
            return _travelPan.GetByDate(travelDate);
        }

        public void TravelPlanAdd(TravelPlan travelPlan)
        {
            _travelPan.Insert(travelPlan);
        }

        public void TravelPlanDelete(TravelPlan travelPlan)
        {
            _travelPan.Delete(travelPlan);

        }

        public void TravelPlanUpdate(TravelPlan travelPlan)
        {
             _travelPan.Update(travelPlan);
        }


        List<TravelPlan> ITravelPlanService.GetList()
        {
            return _travelPan.GetListAll();
        }


    }
}

