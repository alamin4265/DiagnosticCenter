using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using UpdateDiagnosticCenterBillMangementSoftware.DAL;
using UpdateDiagnosticCenterBillMangementSoftware.Model;

namespace UpdateDiagnosticCenterBillMangementSoftware.BLL
{
    public class TypeManager
    {
        TypeGetWay aTypeGetWay=new TypeGetWay();

        public int SaveType(TypeClass aTypeClass)
        {
            return aTypeGetWay.SaveType(aTypeClass);
        }

        public List<TypeClass> GetAllType()
        {
            return aTypeGetWay.GetAllType();
        }

        public TypeClass GetInfoByTypeName(string name)
        {
            return aTypeGetWay.GetInfoByTypeName(name);
        }
    }
}