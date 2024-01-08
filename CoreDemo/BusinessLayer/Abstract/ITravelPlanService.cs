using System;
using EntityLayer.Concrete;

namespace BusinessLayer.Abstract
{
	public interface ITravelPlanService
	{
        void TravelPlanAdd(TravelPlan travelPlan);
        void TravelPlanDelete(TravelPlan travelPlan);
        void TravelPlanUpdate(TravelPlan travelPlan);
        List<TravelPlan> GetList();
        TravelPlan GetByDate(DateTime travelDate);
    }
}

