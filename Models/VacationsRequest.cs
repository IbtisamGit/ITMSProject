

public class VacationRequest : IApprovalStatus
{
    
    private StudentSchedule studentSchedule;
    private VacationSettings vacationSettings;
    private DateTime startDate;
    private DateTime endDate;
    private DateTime createVacationDate;
    private Student student;
    private int VecationRequestID;
    private StatusEnum status;

    public enum StatusEnum
    {
        NewRequest,
        Approved,
        Rejected
    }

    public void createVacationRequest()
    {
         }

    public VacationRequest getVacationRequest()
    {
        return this;
        }

    public void deleteVacationRequest()
    {
        }

    public void cancelVacationRequest()
    {
       
    }

    public void approveRequest()
    {
        
    }

    public void rejectRequest()
    {
       
    }

    public void returnRequest()
    {
        
    } 

    public void newRequest()
    {
       
    }

    public void inProgress()
    {
    }  

}

