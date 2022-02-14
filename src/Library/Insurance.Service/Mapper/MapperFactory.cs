using AutoMapper;
using Insurance.Data.Entity;
using Insurance.Models.Models;
using Insurance.Models.TokenModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Services.Mapper
{
    public class MapperFactory : Profile
    {
        public MapperFactory()
        {
            CreateMap<Customer, CustomerModel>().MaxDepth(1).ReverseMap();
            CreateMap<Disease, DiseaseModel>().MaxDepth(1).ReverseMap();
            CreateMap<DiseaseOfTheInsuredMapping, DiseaseOfTheInsuredMappingModel>().MaxDepth(1).ReverseMap();
            CreateMap<Employee, EmployeeModel>().MaxDepth(1).ReverseMap();
            CreateMap<EmployeeType, EmployeeTypeModel>().MaxDepth(1).ReverseMap();
            CreateMap<InstallmentAmount, InstallmentAmountModel>().MaxDepth(1).ReverseMap();
            CreateMap<InsuredRegistration, InsuredRegistrationModel>().MaxDepth(1).ReverseMap();
            CreateMap<PaymentType, PaymentTypeModel>().MaxDepth(1).ReverseMap();
            CreateMap<Policy, PolicyModel>().MaxDepth(1).ReverseMap();
            CreateMap<PolicyTypeDetails, PolicyTypeDetailsModel>().MaxDepth(1).ReverseMap();
            CreateMap<PolicyType, PolicyTypeModel>().MaxDepth(1).ReverseMap();
            CreateMap<ProximityDegree, ProximityDegreeModel>().MaxDepth(1).ReverseMap();
            CreateMap<PurchaseOrder, PurchaseOrderModel>().MaxDepth(1).ReverseMap();
            CreateMap<PurchaseOrderDetails, PurchaseOrderDetailsModel>().MaxDepth(1).ReverseMap();
            CreateMap<PurchaseOrder, PurchaseOrderModel>().MaxDepth(1).ReverseMap();
            CreateMap<User, LoginModel>().MaxDepth(1).ReverseMap();
            CreateMap<User, UserModel>().MaxDepth(1).ReverseMap();
            CreateMap<User, LoginUserModel>().MaxDepth(1).ReverseMap();
            CreateMap<User, LoginModel>().MaxDepth(1).ReverseMap();
            CreateMap<User, EmployeeModel>().MaxDepth(1).ReverseMap();

        }
    }
}