public class Job{

    public string _company;

    public string _jobTitle;

    public int _startyear;
    
    public int _endyear;

    public void Display(){
        Console.WriteLine($"{_jobTitle} ({_company}) {_startyear}-{_endyear}");
    }
}