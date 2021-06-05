using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderProcessingUnit
{
    public class ProcessResult
    {
        public static readonly string physical_Product_result;
        public static readonly string book_result;
        public static readonly string Membership_result;
        public static readonly string Membership_Upgrade_Result;
        public static readonly string Video_Result;
        public static readonly string Membership_EmailSentTo_Owner;
        public static readonly string Book_Commision_Generated_Toagent;
        public static readonly string UpgradeMembership_EmailSentTo_Owner;
        public static readonly string Physical_Product_Commision_Generated_Toagent;

        static ProcessResult()
        {
            physical_Product_result = "Packing_Slip_For_Shipping";
            book_result = "Duplicate_Packing_Slip_For_The_Royalty_Department";
            Membership_result = "Activate_that_membership";
            Membership_Upgrade_Result = "Apply_The_Upgrade";
            Video_Result = "Learning_to_Ski";
            Membership_EmailSentTo_Owner = "EmailSent_To_Owner";
            Book_Commision_Generated_Toagent = "Commision_Generated_Toagent";
            UpgradeMembership_EmailSentTo_Owner = "EmailSent_To_Owner";
            Physical_Product_Commision_Generated_Toagent = "Commision_Generated_Toagent";
        }

    }
}
