package com.example.week10_quiz2;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.TextView;

public class CountryListItem extends AppCompatActivity {
    TextView textViewCountryName;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_country_list_item);

        init_UI();
    }

    private void init_UI() {
        textViewCountryName = (TextView) findViewById(R.id.textViewCountryName);
    }
}