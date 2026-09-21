<?php

// 1. Code secret aléatoire (ou décommenter pour saisie manuelle)
$codeSecret = rand(0, 9999);
// echo "Définissez le code PIN à 4 chiffres à trouver : ";
// $codeSecret = (int)trim(fgets(STDIN));

echo "Début du programme\n";
$start = microtime(true);

$trouve = false;
$i = 0;
$limiteTentatives = 10000;

// 2. Boucle de force brute
while ($i < 10000 && !$trouve && $i < $limiteTentatives) {
    // Affichage formaté sur 4 chiffres
    echo sprintf('%04d', $i) . " ";

    // Temporisation (Mission 5) : usleep prend des microsecondes (5000 µs = 5 ms)
    // usleep(5000);

    if ($i === $codeSecret) {
        $trouve = true;
        echo "\n\nLe code secret est : " . sprintf('%04d', $i) . "\n";
    } else {
        $i++;
    }
}

if (!$trouve) {
    echo "\n\nÉchec : Nombre maximal de tentatives atteint !\n";
}

echo "Fin du programme\n";

// 3. Calcul de la durée
$duree = microtime(true) - $start;
echo "durée du programme: " . number_format($duree, 6) . " secondes\n";
echo "Fin du programme\n";

// 3. Calcul de la durée
$duree = microtime(true) - $start;
echo "durée du programme: " . number_format($duree, 6) . " secondes\n";
