import random
import time

# 1. Code secret aléatoire (ou décommenter pour saisie manuelle)
code_secret = random.randint(0, 9999)
# code_secret = int(input("Définissez le code PIN à 4 chiffres à trouver : "))

print("Début du programme")
start_time = time.time()

trouve = False
i = 0
limite_tentatives = 10000

# 2. Boucle de force brute
while i < 10000 and not trouve and i < limite_tentatives:
    print(i, end=" ")

    # Temporisation (Mission 5) : 5 ms = 0.005 s / 1 s = 1.0 s
    # time.sleep(0.005)

    if i == code_secret:
        trouve = True
        print(f"\n\nLe code secret est : {i}")

    i += 1

if not trouve:
    print("\n\nÉchec : Nombre maximal de tentatives atteint !")

print("Fin du programme")

# 3. Calcul de la durée
duree = time.time() - start_time
print(f"durée du programme: {duree:.6f} secondes")