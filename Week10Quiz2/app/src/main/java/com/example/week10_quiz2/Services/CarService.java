package com.example.week10_quiz2.Services;

import com.example.week10_quiz2.Models.CarNames;
import com.example.week10_quiz2.R;
import java.util.ArrayList;

public class CarService {
    public static final String EXTRA_CARS = "com.example.week10_quiz2.EXTRA_CARS";

    public static ArrayList<CarNames> getCar() {
        ArrayList<CarNames> list = new ArrayList<CarNames>();

        list.add(new CarNames("1960 Alfa Romeo"));
        list.add(new CarNames("2021 BMW"));
        list.add(new CarNames("1948 Mercedes"));
        list.add(new CarNames("2010 Aston Martin"));
        list.add(new CarNames("2017 Audi"));
        list.add(new CarNames("2016 Bentley"));
        list.add(new CarNames("1960 Chevrolet"));
        list.add(new CarNames("1970 Dodge"));
        list.add(new CarNames("2018 Volkswagen"));
        list.add(new CarNames("2022 Tesla"));

        return list;
    }
}
