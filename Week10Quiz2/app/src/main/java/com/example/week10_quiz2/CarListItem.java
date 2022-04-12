package com.example.week10_quiz2;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.widget.TextView;

public class CarListItem extends AppCompatActivity {
    TextView textViewCarName;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_car_list_item);

        init_UI();
    }

    private void init_UI() {
        textViewCarName = (TextView) findViewById(R.id.textViewCarName);
    }
}