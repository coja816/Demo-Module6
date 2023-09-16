using System;
using System.Collections.Generic;

namespace Demo_Module6.Models;

public partial class CustMasterTbl
{
    public string CustCd { get; set; } = null!;

    public string CustName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PhoneNo { get; set; } = null!;

    public string InsertBy { get; set; } = null!;

    public string UpdateBy { get; set; } = null!;
}
