using AutoMapper;
using FastCode.WebFresher072023.BL.DTO.Foods;
using FastCode.WebFresher072023.BL.Service.Bases;
using FastCode.WebFresher072023.DL.Entity;
using FastCode.WebFresher072023.DL.Repository.Foods;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FastCode.WebFresher072023.BL.Service.Foods
{
    public class FoodService : BaseService<Food, FoodDto, FoodUpdateDto, FoodCreateDto>, IFoodService
    {

        private readonly IFoodRepository _foodRepository;
        private IMapper _mapper;

        //public FoodService(IFoodRepository foodRepository, IMapper mapper) : base(foodRepository, mapper)
        //{
        //    _foodRepository = foodRepository;
        //    _mapper = mapper;
        //    //_foodServiceHobby = foodServiceHobbyService; // Truyền DI 
        //}
    }
}
