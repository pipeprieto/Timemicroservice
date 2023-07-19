namespace TimeMicroservice.Models;

public class DateModel{
    public string Utc {get; set;}

    public string Unix {get; set;}    

    public DateModel(string _Utc, string _Unix){
        this.Utc = _Utc;
        this.Unix = _Unix;
    }

    }