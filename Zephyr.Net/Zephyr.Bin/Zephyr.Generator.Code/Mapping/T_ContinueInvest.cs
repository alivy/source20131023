using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_ContinueInvestMapping : EntityTypeConfiguration<T_ContinueInvest>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public T_ContinueInvestMapping()
        {
            ToTable("T_ContinueInvest");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
