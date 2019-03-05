using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UserProfilesRestApi.Models
{
    public class User
    {
        public string EMPLID;
        public string NAME;
        public string FIRST_NAME;
        public string MIDDLE_NAME;
        public string LAST_NAME;
        public string SECOND_LAST_NAME;
        public string NAME_SUFFIX;
        public string BUSINESS_UNIT;
        public string JOBTITLE;
        public string JOBTITLE_ABBRV;
        public string HP_SUPV_IND;
        public string LOCATION;
        public string LOCATION_DESCR;
        public string DEPTID;
        public string HP_BUS_UNIT_DESCR;
        public string HP_BUS_ORGN_ACR;
        public string HP_BUS_ORGN_DN;
        public string HP_BUS_REGION_ACR;
        public string HP_BUS_REGION_NM;
        public string HP_BUS_SECTOR_CD;
        public string HP_BUS_SECTOR_DN;
        public string HP_ORG_CHRTGRP_ACR;
        public string HP_ORG_CHRT_GRP_DN;
        public string ACCT_CD;
        public string LH_CPNY_CD;
        public string LH_CC;
        public string LH_CTRY_CD;
        public string LH_CTRY_DESC;
        public string LH_SUBRED_CD;
        public string LH_SUBRED_DESC;
        public string LH_BUS_LVL1;
        public string LH_BUS_LVL1_DN;
        public string LH_BUS_LVL2;
        public string LH_BUS_LVL2_DN;
        public string LH_BUS_LVL3;
        public string LH_BUS_LVL3_DN;
        public string LH_BUS_LVL4;
        public string LH_BUS_LVL4_DN;
        public string LH_BUS_LVL5;
        public string LH_BUS_LVL5_DN;
        public string LH_BUS_LVL6;
        public string LH_BUS_LVL6_DN;
        public string SUPERVISOR_ID;
        public string HP_MGR_NAME;
        public string HP_MGR_BUS_UNIT;
        public string HP_JOB_LEVEL;
        public string EMAIL_ADDR;
        public string PER_STATUS;
        public string REG_REGION;
        public string HP_HOST_COMPANY;
        public string HP_HOST_LOCATION;
        public string HP_HOST_LOC_DESCR;
        public string HP_HOST_ACCT_CD;
        public string HP_HOST_BUS_UNIT;
        public string HP_HOST_BUSUNIT_DN;
        public string HP_HOST_MGR_ID;
        public string JOBCODE_FULL;
        public string JOBTITLE_FULL;
        public string MANAGER_EMAIL;
        public string EE_COMPANY;
        public string MGR_COMPANY;
        public User(string empid,string name, string firstname, string middlename,string lastname,string secondlastname,string namesuffix,string bu, string jobtitle,string jobtitleabbrv, 
            string hpsupvind,string location,string locdesc,string deptid,string hpbudesc, string hporgacr,string hporgdn, string hpregionacr, 
            string hpregionnm,string hpsectorcd, string hpsectordn, string hporgchrtgrpacr,string hporgchrtgrpdn, string acctcd, string lhcpnycd,string lhcc, string lhctrycd,string lhctrydesc,
            string lhsubredcd, string lhsubreddesc,string lhbuslvl1,string lhbuslvl1dn,string lhbuslvl2,string lhbuslvl2dn,string lhbuslvl3,string lhbuslvl3dn, string lhbuslvl4,string lhbuslvl4dn, 
            string lhbuslvl5,string lhbuslvl5dn,string lhbuslvl6,string lhbuslvl6dn, string supervisorid,string hpmgrname, string hpmgrbu, string hpjoblevel, string emailaddr, string perstatus,
            string regregion, string hphostcompany, string hphostlocation,string hphostlocdesc, string hphostacctcd, string hphostbu,string hphostbudn,string hphostmgrid,string jobcodefull, string jobtitlefull,
            string manageremail,string eecompany,string mgrcompany)
        {
           
            this.EMPLID = empid;
            this.NAME = name;
            this.FIRST_NAME = firstname;
            this.MIDDLE_NAME = middlename;
            this.LAST_NAME = lastname;
            this.SECOND_LAST_NAME = secondlastname;
            this.NAME_SUFFIX = namesuffix;
            this.BUSINESS_UNIT = bu;
            this.JOBTITLE = jobtitle;
            this.JOBTITLE_ABBRV = jobtitleabbrv;
            this.HP_SUPV_IND = hpsupvind;
            this.LOCATION = location;
            this.LOCATION_DESCR = locdesc;
            this.DEPTID = deptid;
            this.HP_BUS_UNIT_DESCR = hpbudesc;
            this.HP_BUS_ORGN_ACR = hporgacr;
            this.HP_BUS_ORGN_DN = hporgdn;
            this.HP_ORG_CHRTGRP_ACR = hporgacr;
            this.HP_ORG_CHRT_GRP_DN = hporgdn;
            this.HP_BUS_REGION_ACR = hpregionacr;
            this.HP_BUS_REGION_NM = hpregionnm;
            this.HP_BUS_SECTOR_CD = hpsectorcd;
            this.HP_BUS_SECTOR_DN = hpsectordn;
            this.HP_ORG_CHRTGRP_ACR = hporgchrtgrpacr;
            this.HP_ORG_CHRT_GRP_DN = hporgchrtgrpdn;
            this.ACCT_CD = acctcd;
            this.LH_CPNY_CD = lhcpnycd;
            this.LH_CC = lhcc;
            this.LH_CTRY_CD = lhctrycd;
            this.LH_CTRY_DESC = lhctrydesc;
            this.LH_SUBRED_CD = lhsubredcd;
            this.LH_SUBRED_DESC = lhsubreddesc;
            this.LH_BUS_LVL1 = lhbuslvl1;
            this.LH_BUS_LVL1_DN = lhbuslvl1dn;
            this.LH_BUS_LVL2 = lhbuslvl2;
            this.LH_BUS_LVL2_DN = lhbuslvl2dn;
            this.LH_BUS_LVL3 = lhbuslvl3;
            this.LH_BUS_LVL3_DN = lhbuslvl3dn;
            this.LH_BUS_LVL4 = lhbuslvl4;
            this.LH_BUS_LVL4_DN = lhbuslvl4dn;
            this.LH_BUS_LVL5 = lhbuslvl5;
            this.LH_BUS_LVL5_DN = lhbuslvl5dn;
            this.LH_BUS_LVL6 = lhbuslvl6;
            this.LH_BUS_LVL6_DN = lhbuslvl6dn;
            this.SUPERVISOR_ID = supervisorid;
            this.HP_MGR_NAME = hpmgrname;
            this.HP_MGR_BUS_UNIT = hpmgrbu;
            this.HP_JOB_LEVEL = hpjoblevel;
            this.EMAIL_ADDR = emailaddr;
            this.PER_STATUS = perstatus;
            this.REG_REGION = regregion;
            this.HP_HOST_COMPANY = hphostcompany;
            this.HP_HOST_LOCATION = hphostlocation;
            this.HP_HOST_LOC_DESCR = hphostlocdesc;
            this.HP_HOST_ACCT_CD = hphostacctcd;
            this.HP_HOST_BUS_UNIT = hphostbu;
            this.HP_HOST_BUSUNIT_DN = hphostbudn;
            this.HP_HOST_MGR_ID = hphostmgrid;
            this.JOBCODE_FULL = jobcodefull;
            this.JOBTITLE_FULL = jobtitlefull;
            this.MANAGER_EMAIL = manageremail;
            this.EE_COMPANY = eecompany;
            this.MGR_COMPANY = mgrcompany;

        }
    }
}