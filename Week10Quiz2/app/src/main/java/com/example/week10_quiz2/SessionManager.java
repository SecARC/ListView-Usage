package com.example.week10_quiz2;

import static android.content.Context.MODE_PRIVATE;

import android.content.Context;
import android.content.SharedPreferences;

public class SessionManager {
    private String KEY_NAME = "com.example.week10_quiz2.KEY_NAME";

    Context context;
    SharedPreferences settings;
    SharedPreferences.Editor editor;

    public SessionManager(Context context) {
        this.context = context;
        settings = context.getSharedPreferences("com.example.week10_quiz2",MODE_PRIVATE);
        editor = settings.edit();
    }

    public void setName(String name){
        editor.putString(KEY_NAME, name);
        editor.commit();
    }

    public String getName(){
        String value = settings.getString(KEY_NAME, "");
        return value;
    }
}
