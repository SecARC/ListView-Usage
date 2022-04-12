package com.example.week10_quiz2.Models;

import java.io.Serializable;

public class CarNames implements Serializable {
    private String name;

    public CarNames(String name){
        this.name = name;
    }

    public String getCarName() { return name; }

    public void setCarName(String name) {
        this.name = name;
    }

    @Override
    public String toString() { return getCarName(); }
}
