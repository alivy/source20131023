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
    public class T_DiamondMemberStatisticsRepository : BaseRepository<T_DiamondMemberStatistics>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public T_DiamondMemberStatisticsRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

