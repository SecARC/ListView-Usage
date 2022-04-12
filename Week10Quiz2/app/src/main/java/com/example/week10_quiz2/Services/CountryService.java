package com.example.week10_quiz2.Services;

import com.example.week10_quiz2.Models.CountryNames;
import com.example.week10_quiz2.R;
import java.util.ArrayList;

public class CountryService {
    public static final String EXTRA_COUNTRY = "com.example.week10_quiz2.EXTRA_COUNTRY";

    public static ArrayList<CountryNames> getCountry() {
        ArrayList<CountryNames> list2 = new ArrayList<CountryNames>();

        list2.add(new CountryNames("Turkey"));
        list2.add(new CountryNames("Germany"));
        list2.add(new CountryNames("United States"));
        list2.add(new CountryNames("England"));
        list2.add(new CountryNames("France"));
        list2.add(new CountryNames("Spain"));
        list2.add(new CountryNames("Portugal"));
        list2.add(new CountryNames("Belgium"));
        list2.add(new CountryNames("Holland"));
        list2.add(new CountryNames("Denmark"));
        list2.add(new CountryNames("Sweden"));
        list2.add(new CountryNames("Norway"));
        list2.add(new CountryNames("China"));
        list2.add(new CountryNames("Japan"));
        list2.add(new CountryNames("Canada"));

        return list2;
    }
}
