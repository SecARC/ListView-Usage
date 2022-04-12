package com.example.week10_quiz2.Activities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;

import com.example.week10_quiz2.Models.CarNames;
import com.example.week10_quiz2.Models.CountryNames;
import com.example.week10_quiz2.R;
import com.example.week10_quiz2.Services.CarService;
import com.example.week10_quiz2.Services.CountryService;
import com.example.week10_quiz2.SessionManager;

public class MainActivity extends AppCompatActivity {
    EditText editTextTextPersonName;
    TextView textViewCountry, textViewCar;
    Button buttonCountryChange, buttonCarChange;
    SessionManager session;
    CountryNames items;
    CarNames item;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        session = new SessionManager(MainActivity.this);

        init_UI();

        editTextTextPersonName.setText(session.getName());
    }

    private void init_UI() {
        editTextTextPersonName = (EditText) findViewById(R.id.editTextTextPersonName);
        buttonCountryChange = (Button) findViewById(R.id.buttonCountryChange);
        buttonCarChange = (Button) findViewById(R.id.buttonCarChange);
        textViewCountry = (TextView) findViewById(R.id.textViewCountry);
        textViewCar = (TextView) findViewById(R.id.textViewCar);

        buttonCountryChange.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(!editTextTextPersonName.getText().toString().trim().equals(session.getName().trim())){
                    session.setName(editTextTextPersonName.getText().toString());
                }
                Intent i = new Intent(MainActivity.this, CountryActivity.class);
                startActivity(i);

                Intent getCountryIntent = getIntent();
                items = (CountryNames) getCountryIntent.getSerializableExtra(CountryService.EXTRA_COUNTRY);
                textViewCountry.setText(items.getCountryName());
            }
        });

        buttonCarChange.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                if(!editTextTextPersonName.getText().toString().trim().equals(session.getName().trim())){
                    session.setName(editTextTextPersonName.getText().toString());
                }
                Intent j = new Intent(MainActivity.this, CarActivity.class);
                startActivity(j);

                Intent getCarIntent = getIntent();
                item = (CarNames) getCarIntent.getSerializableExtra(CarService.EXTRA_CARS);
                textViewCar.setText(item.getCarName());
            }
        });

    }
}