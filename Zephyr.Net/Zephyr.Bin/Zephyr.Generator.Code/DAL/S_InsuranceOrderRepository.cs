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
    public class S_InsuranceOrderRepository : BaseRepository<S_InsuranceOrder>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public S_InsuranceOrderRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}
