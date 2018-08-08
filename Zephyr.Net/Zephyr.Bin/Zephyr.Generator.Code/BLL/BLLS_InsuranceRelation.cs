using DAL;
using EntityModel.Models;
using Model.Article;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BLL
{
    public class S_InsuranceRelationBLL : BaseBLL<S_InsuranceRelation>
    {
        public S_InsuranceRelationDal Creat_Dal = null;
        public override void SetDal()
        {
            _baseDal = new S_InsuranceRelationDal();
        }      
    }
}