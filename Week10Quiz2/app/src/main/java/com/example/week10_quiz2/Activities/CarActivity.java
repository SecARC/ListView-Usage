package com.example.week10_quiz2.Activities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import com.example.week10_quiz2.Models.CarNames;
import com.example.week10_quiz2.Models.CountryNames;
import com.example.week10_quiz2.R;
import com.example.week10_quiz2.Services.CarService;
import com.example.week10_quiz2.Services.CountryService;

public class CarActivity extends AppCompatActivity {
    ListView listViewCar;
    CarNames clickedItem;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_car);

        init_UI();

        ArrayAdapter<CarNames> adapter= new ArrayAdapter<CarNames>(CarActivity.this,R.layout.activity_car_list_item,R.id.textViewCarName, CarService.getCar());
        listViewCar.setAdapter(adapter);
    }

    private void init_UI() {
        listViewCar = (ListView) findViewById(R.id.listViewCar);



        listViewCar.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                Intent j = getIntent();
                CarNames item = (CarNames) j.getSerializableExtra(CarService.EXTRA_CARS);

                Intent k = new Intent(CarActivity.this,MainActivity.class);
                clickedItem = (CarNames) listViewCar.getItemAtPosition(position);
                k.putExtra(CarService.EXTRA_CARS, clickedItem);
                startActivity(k);
            }
        });
    }
}