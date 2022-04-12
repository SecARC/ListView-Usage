package com.example.week10_quiz2.Models;

import java.io.Serializable;

public class CountryNames implements Serializable {
    private String name;

    public CountryNames(String name){
        this.name = name;
    }

    public String getCountryName() { return name; }

    public void setName(String name) {
        this.name = name;
    }

    @Override
    public String toString() { return getCountryName(); }
}
