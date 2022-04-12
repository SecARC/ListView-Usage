package com.example.week10_quiz2.Activities;

import androidx.appcompat.app.AppCompatActivity;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.ListView;

import com.example.week10_quiz2.Models.CarNames;
import com.example.week10_quiz2.Services.CarService;
import com.example.week10_quiz2.Services.CountryService;
import com.example.week10_quiz2.R;
import com.example.week10_quiz2.Models.CountryNames;

public class CountryActivity extends AppCompatActivity {
    ListView listViewCountry;
    CountryNames clickedItems;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_country);

        init_UI();

        ArrayAdapter<CountryNames> adapter= new ArrayAdapter<CountryNames>(CountryActivity.this,R.layout.activity_country_list_item,R.id.textViewCountryName, CountryService.getCountry());
        listViewCountry.setAdapter(adapter);
    }

    private void init_UI() {
        listViewCountry = (ListView) findViewById(R.id.listViewCountry);

        listViewCountry.setOnItemClickListener(new AdapterView.OnItemClickListener() {
            @Override
            public void onItemClick(AdapterView<?> parent, View view, int position, long id) {

                Intent i = getIntent();
                CountryNames items = (CountryNames) i.getSerializableExtra(CountryService.EXTRA_COUNTRY);

                Intent m = new Intent(CountryActivity.this,MainActivity.class);
                clickedItems = (CountryNames) listViewCountry.getItemAtPosition(position);
                m.putExtra(CountryService.EXTRA_COUNTRY, clickedItems);
                startActivity(m);
            }
        });
    }
}