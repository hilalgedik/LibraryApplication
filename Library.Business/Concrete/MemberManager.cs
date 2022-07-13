using Library.Business.ValidationRules.FluentValidation;
using Library.DataAccess;
using Library.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Business.Concrete
{
    public class MemberManager
    {
        private MemberDal _memberDal;

        public MemberManager(MemberDal memberDal)
        {
            _memberDal = memberDal;
        }

        //private void CheckIfMemberExists(Member member)
        //{
        //    List<Member> members = new List<Member>();
        //    if ((m => m.Uye_Id == member.Uye_Id) != null)
        //    {
        //        throw new Exception("Bu kullanıcı daha önce kayıt olmuştur");
        //    }
        //}

        [FluentValidationAspect(typeof(MemberValidator))]
        public void Add(Member member)
        {
            //CheckIfMemberExists(member);
            _memberDal.Add(member);
        }
    }
}
