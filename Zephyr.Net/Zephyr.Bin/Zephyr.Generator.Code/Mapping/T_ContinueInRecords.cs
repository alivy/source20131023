using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace QFTService.Domain
{
  
    public class T_ContinueInRecordsMapping : EntityTypeConfiguration<T_ContinueInRecords>
    {
        /// <summary>
        /// ��Ҫӳ���ֶ�
        /// </summary>
        public T_ContinueInRecordsMapping()
        {
            ToTable("T_ContinueInRecords");

            //HasKey(m => m.id);
            //Property(m => m.UserName).HasColumnType("nvarchar").HasMaxLength(50);
           
        }
    }
}
