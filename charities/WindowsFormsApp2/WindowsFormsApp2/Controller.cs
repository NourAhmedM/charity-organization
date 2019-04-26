using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    class Controller
    {
        private DBManager dbMan; // A Reference of type DBManager 
                                 // (Initially NULL; NO DBManager Object is created yet)

        public Controller()
        {
            dbMan = new DBManager(); // Create the DBManager Object
        }




        public int insertcharity(int id, string fname, string chname, DateTime year)
        {
            string query = "INSERT INTO charity_org (CH_ID, foundername, ch_name, yearoffound) Values (" +
                            +id + ",'" +fname + "','" + chname + "','" + year + "');";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getbranches()
        {
            string query = "select branch_no,adress from branch ";
            return dbMan.ExecuteReader(query);
        }
        
        public int createevent(int id, int branch_no, int chid, string loc,string campaign_name,string campaign_desc,DateTime startingDate,DateTime endingDate)
        {
            string query = "INSERT INTO campaign (campaign_id, branch_no, charity_id, location,campaign_name,campaign_desc,starting_date,ending_date) Values (" +
                            +id + "," + branch_no + "," + chid + ",'" + loc + "','"+campaign_name+"','"+campaign_desc+"','"+startingDate+"','"+endingDate+"')";
            return dbMan.ExecuteNonQuery(query);
        }
        public int insertcase(int ssn, string fname, string lname,int age, string job, char gender, string mstatus, string address, string phone_number,int brID,int chID,string studyStage,int dublic,string desc)
        {
            string query = "INSERT INTO cases (ssn, Fname, Lname, age,job,gender,marriage_status,c_address,ph_num,branch_no,charity_id,study_stage,dupication,c_describtion) Values (" +
                            +ssn + ",'" + fname + "','" + lname + "'," +age + ",'" + job + "','" + gender + "','" + mstatus + "','" + address + "','"+phone_number+"',"+brID+","+chID+",'"+studyStage+"',"+dublic+"'"+desc+"')";
            return dbMan.ExecuteNonQuery(query);
        }



        public int insertDonor(int dSSN,string dFName,string dLName,string dAddress,string dEmail
            ,DateTime dDateOfBirth,int dPhoneNumber,string dJob,string dMarriageStatus,string dStudyStage
            ,string dGender,int age)
        {
            string query = "insert into Donor (SSN,Fname,Lname,d_address,email,dateOfBirth,ph_num,job,marriage_status,study_stage,gender,age) values(" + dSSN + ",'" + dFName + "','" + dLName + "','"
                + dAddress + "','" + dEmail + "','" + dDateOfBirth.ToString("yyyy-MM-dd") + "'," + dPhoneNumber + ",'" + dJob + "','"
                +dMarriageStatus+"','"+dStudyStage+"','"+dGender+"',"+age+")";
            return dbMan.ExecuteNonQuery(query);
        }

        public int insertVolunteer(int dSSN)
        {
            string query = "insert into Volunteer (SSN) values(" + dSSN + ")";

            return dbMan.ExecuteNonQuery(query);
        }

        public int insertSponsor(int dSSN,string dOrgName,string dLogoCode)
        {
            string query = "insert into sponsor (SSN,org_name,logocode) values(" + dSSN +",'"+dOrgName+"','"
                +dLogoCode+"')";

            return dbMan.ExecuteNonQuery(query);
        }



        public int CheckPassword_Basic(string username, string password)
        {
            //Query the DB to check for username/password
            string query = "SELECT priv from userBasic where username = '" + username + "' and password='" + password + "';";
            object p = dbMan.ExecuteScalar(query);
            if (p == null) return -1;
            else return (int)p;
        }


        public DataTable getInfoOfBranch (int charityId,int branchno)
        {
            string query = "select founderName,yearOfFound,EMAIL,PHONE from branch as b,charity_org as c where  c.CH_ID =b.CH_ID and c.CH_ID = " + charityId + " and b.BRANCH_NO = " + branchno;
            return dbMan.ExecuteReader(query);
        }

        public DataTable getStockOfSpecificBranch(int charityId, int branchno)
        {
            string query = "select typee+':'+subtype as needs from stock as s where s.branch_no=" + branchno + " and s.charity_id=" + charityId + " and qty < 5";
            return dbMan.ExecuteReader(query);
        }

        public int insertUserBasic(string username,string password,int priv)
        {
            string query = "insert into userBasic (username,password,priv) values ('"+username+"','"+password+"',"+priv+")";

            return dbMan.ExecuteNonQuery(query);
        }



        //-------------menna queries---------------------- 
        public int getDonorSSN(string userName)
        {
            string query = "SELECT SSN FROM donor where user_name = '" + userName + "' ;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int getDonationID(string userName, DateTime date)
        {
            string query = "SELECT donation_id FROM donations where user_name = '" + userName +
                           " and date_of_donation = '" + date + "' ;";
            return (int)dbMan.ExecuteScalar(query);
        }

        public int MaxDonationID()
        {
            string query = " SELECT MAX (Donation_id) From Donations; ";
            return (int)dbMan.ExecuteScalar(query);

        }

        public int InsertDonation(int donorSSN, int donationID, DateTime dateOfDonation, int branchNum, int charityID)
        {

            string query = "INSERT INTO donations (D_SSN, donation_id, date_of_donation, branch_no, charity_id,accepted)" +
                            " Values (" + donorSSN + "," + donationID + "," + dateOfDonation.ToString("yyyy-MM-dd") + ","
                            + branchNum + "," + charityID + ",0);";

            return dbMan.ExecuteNonQuery(query);
        }
        public int insertbranch(int brno, int chid, string add, string em, int ph)
        {
            string query = "insert into BRANCH(BRANCH_NO,CH_ID,ADRESS,EMAIL,PHONE,BRANCH_NAME) values (" + brno + "," + chid + ",'" + add + "','" + em + "'," + ph + ",'" + add + "')";

            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertKindOfDonation(int donorSSN, int donationID, string don_type, string don_subtype, int quantity)
        {
            string query = "INSERT INTO kind_of_don (D_SSN, Donation_id, type_, subtype, qty)" +
                            "Values (" + donorSSN + "," + donationID + ",'" + don_type + "','" + don_subtype +
                            "', " + quantity + " );";

            return dbMan.ExecuteNonQuery(query);
        }

        public int InsertCaseDonation(int donorSSN, int caseSSN)
        {
            string query = "INSERT INTO caseDonation (donor_ssn, case_ssn)" +
                            "Values (" + donorSSN + "," + caseSSN + " );";
            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable SelectDonationsOfDonor(int donorSSN)
        {
            string query = "SELECT * "
             + "FROM donations"
             + "where "
             + "D_SSN=" + donorSSN + ";";

            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewCases(int charityNumber, int branchNumber)
        {
            string query = "SELECT Fname, Lname, C_address as address_, age, ph_num as Number, job, marriage_status, study_stage, gender, c_description, SSN "
                         + "FROM cases "
                         + "where charity_id=" + charityNumber + " and branch_no = " + branchNumber;

            return dbMan.ExecuteReader(query);
        }

        public DataTable ViewCampaigns(int charityNumber, int branchNumber)
        {
            string query = "SELECT * "
             + "FROM campaign "
             + "where "
             + "charity_id=" + charityNumber + "and branch_no=" + branchNumber + ";";

            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectCharityNum_and_Name()
        {
            string query = "SELECT CH_ID , CH_NAME FROM charity_org;";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectbranchNum_and_Name(int charityID)
        {
            string query = "SELECT BRANCH_NO,BRANCH_NAME FROM branch WHERE ch_id = " + charityID;
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectPreviousDonations(string user_name)
        {

            string query = "SELECT Donation_id as donation_number, date_of_donation as date_,"
                         + "receipt_no as receipt_number, branch_name, ch_name as charity_Name "
                         + " FROM DONATIONS, CHARITY_ORG, BRANCH, donor"
                         + " WHERE "
                         + " DONATIONS.branch_no = branch.branch_no "
                         + " and donations.charity_id = charity_org.ch_id "
                         + " and donations.d_ssn= donor.SSN "
                         + " and donor.user_name = '" + user_name + "'";
            return dbMan.ExecuteReader(query);
        }

        public DataTable SelectRecievedInvitations(string user_name)
        {

            string query = "SELECT CH_NAME as Charity_Name, branch_name, campaign_desc as Campaign_Description, "
                         + " location as campaign_location, "
                         + " starting_date,  "
                         + " ending_date, "
                         + " bi.donor_ssn, "
                         + " bi.campaign_id, "
                         + " bi.branch_no, "
                         + " bi.charity_id "
                         + " FROM Branch as b, Charity_org as ch, branchInvitations as bi, campaign as c, donor as d "
                         + " WHERE "
                         + " bi.branch_no= b.branch_no "   // join conditions
                         + " and bi.charity_id= b.ch_id "
                         + " and bi.campaign_id= c.campaign_id "
                         + " and bi.donor_ssn= d.ssn "
                         + " and d.user_name = '" + user_name + "'"
                         + " accept = 0";  // condition
            return dbMan.ExecuteReader(query);
        }

        public int UpdatebranchInvitations(int donorSSN, int Camp_id, int branchNumber, int CharityID)
        {
            string query = "UPDATE branchinvitations SET " +
                " accept= " + 1 + " " +
                " WHERE donor_ssn = " + donorSSN +
                " and campaign_id= " + Camp_id +
                " and branch_no= " + branchNumber +
                " and charity_id= " + CharityID;

            return dbMan.ExecuteNonQuery(query);
        }


        public int updatedonorbyusername(int donorSSN,string username)
        {
            string query = "UPDATE donor SET " +
                " user_name= '" + username+ "' " +
                " WHERE SSN = " + donorSSN;

            return dbMan.ExecuteNonQuery(query);
        }
        

        //queries of mariam-----------------------------------
       
        //
        public DataTable getbranchesforcharity(int x)
        {
            string query = " select branch_no,adress from branch where CH_ID=" + x;
            return dbMan.ExecuteReader(query);
        }
        //
        public DataTable getCharities()
        {

            string query = "select ch_id,ch_name from charity_org ";
            return dbMan.ExecuteReader(query);
        }
        //
        public DataTable getdonor()
        {

            string query = "select lname,ssn from donor ";
            return dbMan.ExecuteReader(query);
        }
        //
        public DataTable getevent(int x, int y)
        {

            string query = "select campaign_id,campaign_name from campaign where branch_no =" + y + "and charity_id =" + x;
            return dbMan.ExecuteReader(query);
        }
        //
        public DataTable SelectAlldonations()
        {

            string query = "select * from Donations where accepted =0";
            return dbMan.ExecuteReader(query);
        }
        //
        public int sendinv(int ssn, int cid, int br, int ch)
        {
            string query = "insert into branchInvitations (donor_ssn , campaign_id ,branch_no  ,charity_id ) Values ("
                            + ssn + "," + cid + "," + br + "," + ch + ")";
            return dbMan.ExecuteNonQuery(query);
        }
        //
        public int acceptdon(int donid, int ssn)
        {
            string query = "update donations set accepted = 1	where Donation_id=" + donid + " and D_SSN=" + ssn;

            return dbMan.ExecuteNonQuery(query);
        }
        //
        public int instock(int donid, int ssn)
        {
            string query = "insert into stock select branch_no, charity_id, type_, subtype, qty from donations d,KIND_OF_DON k where d.D_SSN = k.D_SSN and d.Donation_id = k.Donation_id and d.D_SSN =" + ssn + " and d.Donation_id =" + donid;

            return dbMan.ExecuteNonQuery(query);
        }
        
        //
        public int addqty(int donid, int ssn)
        {
            string query = "update stock set qty += k.qty from  donations d,KIND_OF_DON k,stock s  where  d.D_SSN = k.D_SSN and d.Donation_id = k.Donation_id and d.branch_no=s.branch_no and d.charity_id=s.charity_id and typee=type_ and s.subtype=k.subtype and d.D_SSN = " + ssn + " and d.Donation_id =" + donid;

            return dbMan.ExecuteNonQuery(query);
        }

        public int updatepassword(string username,string password)
        {
            string query = "UPDATE userBasic SET " +
                " password= '" + password + "' " +
                " WHERE username = '" + username +"'";

            return dbMan.ExecuteNonQuery(query);
        }

        public DataTable getdates() {
            string query = "select starting_date from volunteer";
            return dbMan.ExecuteReader(query);
        }
    }
}
