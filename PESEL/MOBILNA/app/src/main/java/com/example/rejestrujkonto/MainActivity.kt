package com.example.rejestrujkonto

import android.annotation.SuppressLint
import android.os.Bundle
import android.widget.Button
import android.widget.EditText
import android.widget.TextView
import android.widget.Toast
import androidx.activity.enableEdgeToEdge
import androidx.appcompat.app.AppCompatActivity
import androidx.core.view.ViewCompat
import androidx.core.view.WindowInsetsCompat

class MainActivity : AppCompatActivity() {
    @SuppressLint("MissingInflatedId")
    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        enableEdgeToEdge()
        setContentView(R.layout.activity_main)
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main)) { v, insets ->
            val systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars())
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom)
            insets
        }

        val email: EditText = findViewById(R.id.email)
        val password: EditText = findViewById(R.id.password)
        val samePassword: EditText = findViewById(R.id.samePassword)
        val confirm: Button = findViewById(R.id.confirm)
        val emailText: TextView = findViewById(R.id.emailText)


        confirm.setOnClickListener {
            if (email.text.toString().contains("@")) {
                if (password.text.toString() == samePassword.text.toString()) {
                    emailText.text = "Witaj ${email.text.toString()}"
                }
                else {
                    emailText.text = "Hasła się różnią"
                }
            }
            else {
                emailText.text = "Nieprawidłowy adres e-mail"
            }
        }
    }
}