[System.Serializable]
public class Weather {
    public class coord {
        float lon;
        float lat;
    };
    public class weather {
        int id;
        string main;
        string description;
        string icon;
    }
    public class main {
        float temp;
        float feels_like;
        float temp_min;
        float temp_max;
        int pressure;
        int humidity; 
    }
    public float visibility;
    public class wind {
        float speed;
        int deg;
    }
    public class clouds {
        int all;
    }
    public int dt;
    public class sys {
        int type;
        int id;
        string country;
        int sunrise;
        int sunset;
    }
    public int timezone;
    public int id;
    public string name;
    public int cod; 

}
