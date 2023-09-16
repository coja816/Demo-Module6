//Step 1: we import data.sqlclinet and FrameworkCore
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;


namespace Demo_Module6.Models
{
    public class CustMasterTblService
    {
        //Step 2: In this section we create the object for our DBContext in order to execute
        //the stored proc.
        private readonly Module6PracticeContext _context;
        public CustMasterTblService(Module6PracticeContext context)
        {
            _context = context;
        }
        //Step 3: we create the async method to return the customer details as array, also
        //we can see in this method we use the FromSQLRaw to execute the Stored Procedure
        //with CustCD and CustName as the parameters
        public async Task<CustMasterTbl[]> GetCusttomerAync(string CustCD, String CustName)
        {
            CustMasterTbl[] custObjs;
            var CustCDs = CustCD;
            var CustNames = CustName;
            SqlParameter param1 = new SqlParameter("@CustCD", CustCD);
            SqlParameter param2 = new SqlParameter("@CustName", CustName);
            custObjs = _context.CustMasterTbls.FromSqlRaw("Execute dbo.usp_CustDetails @CustCd, @CustName", param1, param2).ToArray();
        return custObjs;
        }
    }
}