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
    public class C_ChipsBonusRepository : BaseRepository<C_ChipsBonus>, ISubJectBidRecordRepository
    {
        IUnitOfWork _unit;
        public C_ChipsBonusRepository(IUnitOfWork unit)
            : base(unit)
        {
            _unit = unit;
        }
    }
}

