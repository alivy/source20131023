using QFTService.Domain;
using QFTService.Domain.Repository.Interfaces;
using QFTService.DtoModel;
using QFTService.Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QFTService.Repository
{
    /// <summary>
    /// Ͷ����Ŀ�ִ�
    /// </summary>
    public class F_TemplateManageRepository : BaseRepository<F_TemplateManage>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public F_TemplateManageRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

