package com.github.perzotprogrammer.inf04styczen2026;

import android.os.Bundle;
import android.widget.Button;
import android.widget.ImageButton;
import android.widget.TextView;

import androidx.activity.EdgeToEdge;
import androidx.appcompat.app.AppCompatActivity;
import androidx.core.graphics.Insets;
import androidx.core.view.ViewCompat;
import androidx.core.view.WindowInsetsCompat;

public class MainActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        EdgeToEdge.enable(this);
        setContentView(R.layout.activity_main);
        ViewCompat.setOnApplyWindowInsetsListener(findViewById(R.id.main), (v, insets) -> {
            Insets systemBars = insets.getInsets(WindowInsetsCompat.Type.systemBars());
            v.setPadding(systemBars.left, systemBars.top, systemBars.right, systemBars.bottom);
            return insets;
        });


        Kosc[] kosci = {
                new Kosc(0),
                new Kosc(0),
                new Kosc(0),
                new Kosc(0),
                new Kosc(0),
        };

        ImageButton[] kosciGrafika = {
                findViewById(R.id.kosc_1_image_button),
                findViewById(R.id.kosc_2_image_button),
                findViewById(R.id.kosc_3_image_button),
                findViewById(R.id.kosc_4_image_button),
                findViewById(R.id.kosc_5_image_button)
        };

        TextView wynikTekst = findViewById(R.id.wynik_text);

        Button rzutButton = findViewById(R.id.rzut_button);

        rzutButton.setOnClickListener(l -> {
            int suma = 0;
            for (int i = 0; i < 5; i++) {
                if (!kosci[i].CzyDostepna) {
                    suma += kosci[i].WyrzuconaWartosc;
                    continue;
                }

                kosci[i].rzut();
                kosciGrafika[i].setImageResource(kosci[i].Obrazy[kosci[i].ObrazIndeks]);
                suma += kosci[i].WyrzuconaWartosc;
            }
            wynikTekst.setText("" + suma);
        });


        for (int i = 0; i < 5; i++) {
            int finalI = i;
            kosciGrafika[i].setOnClickListener(l -> {
                if (kosci[finalI].CzyDostepna) {
                    kosci[finalI].CzyDostepna = false;
                    kosciGrafika[finalI].setAlpha(0.5f);
                } else {
                    kosci[finalI].CzyDostepna = true;
                    kosciGrafika[finalI].setAlpha(1f);
                }
            });
        }
    }
}