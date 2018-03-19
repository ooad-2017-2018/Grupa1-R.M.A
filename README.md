# :globe_with_meridians: R.M.A.

## Članovi tima
- Appa Bugis Ridvan
- Fišić Mak
- Jajčanin Ajdin

![logo](https://github.com/ooad-2017-2018/Grupa1-R.M.A/blob/master/resursi/logo.png)

## Air-X :airplane:
Air-X je vrhunski sistem koji nudi uslugu korisničkog interface-a aviokompanije, te pruža različite pogodnosti i olakšice klijentima pri korištenju usluga kompanije.

Rezervacija letova te kupovina karti za iste sa ovim sistemom postaje elektronska, čime se odstranjuje potreba za salterima i dolazi do uštede radne *snage, vremena i novca*.

## Procesi :eight_pointed_black_star: 

**Pretrazivanje** letova je znatno lakše, sa mnogobrojnim filterima i dodatnom **interaktivnom mapom** svijeta koja se može koristiti pored tradicionalnog type-and-search pristupa za pretragu letova. Nakon online plaćanja na mail će biti dostavljena pdf verzija karte koja sadrži informacije o putniku i letu, te bar-kod za identifikaciju i potvrdu ulaska na let. Pored pdf verzije, dozvoljena je i fizička kopija za ulazak na let. Nakon što karta bude predstavljena odgovarajućem uposleniku, te je **skenirana** putem skenera, informacija da je klijent pristupio letu će biti poslana sistemu i ažurirana.

Korisnici sistema koji nemaju registrovan account će biti u mogućnosti pretraživati sve ponude aviokompanije, dok registrovani korisnici imaju pristup **svim** korisničkim funkcionalnostima. 
**Registracija** će biti omogućena svim posjetiocima sistema. Standardni unos bitnih informacija u zavisnosti od tipa registracije - da li se prijavljuje pojedinac ili agencija. Pored toga, potrebno je povezati account sa željenim načinom uplate kao što je paypal ili kreditna kartica.

Nakon registracije korisniku će biti omogućeno **upravljanje postojećim rezervisanim letovima**, te dodavanje **novih**. Prilikom dodavanja novih letova korisnik ima pristup *informacijama željenog leta, te odabir putničke klase, broj mjesta, opciju biranja težine prtljaga i mogućnost kupovanja dodatnih karti*. Također će biti u mogućnosti pratiti obavještenja za zakazane letove i informacije o posebnim ponudama u vidu **notifikacija**. Po želji korisnik može odgoditi svoj let uz (ne)mogućnost **reklamacije** u zavisnosti od vremena odgađanja.  

Supervizoru kompanijskog sistema Air-X će biti dostupno **ažuriranje** postojećih letova, te će svaka osoba koja je prijavljena na izabrani let dobiti informaciju, u vidu notifikacija, o dodanoj izmjeni. *Dodavanje novih letova, odgađanje istih, te puno upravljanje sistemom je također omogućeno.*

Za one koji često putuju tu je VIP klub sa dodatnim pogodnostima.

## Funkcionalnosti :eight_pointed_black_star:
**Za posjetioce:**
  - Pretraga letova i pregled obavijesti
  - Registracija accounta
  
**Za registrovane pojedince:**
  - Log-in u sistem
  - Rezervacija i odgađanje rezervisanih letova
  - Notifikacije o rezervisanim letovima i posebnim ponudama
  - Elektronsko plaćanje karti
  - Učlanjenje u VIP klub 
  - Detaljan sistem rezervacije letova sa opcijama:
    - Odabir putničke klase
    - Odabir željenog sjedišta
    - Odabir količine prtljaga
  - **Za VIP pojedince:**
    - Mogućnost rezervacije leta bez uplate do određenog roka
    - Dodatne pogodnosti na cijenu
    - Veći prioritet pri rezervaciji leta i sjedišta
    
**Za registrovane agencije:** 
  - Kupovina karti na veliko bez potrebe upisivanja informacija o putnicima
  - Rezervacija čitavog leta, sa uplatom na rate ili keš
  - Opcija slanja zahtjeva za nove letove, sa dokazom da je ta destinacija željena među putnicima
 
**Za supervizore:**
  - Upravljanje bazom podatak sistema
  - Izmjena i dopuna informacija o letovima, avionima, korisnika
  - Slanje notifikacija o letovima
  - Slanje obavijesti na obavještajni panel glavnog meni-a sistema, pristupan svim korsnicima
  - Pregled statistika letova i korisinika
  
**Za supervizore:**
  - Puna kontrola nad sistemom za svrhu održavanja sistema
  - Upravljanje bazom podataka uz dopuštenje supervizora
  
**Za kompaniju:**
  - Ažuriranje postojećih letova, prilikom svake izmjene na postojećem letu, svim rezervisanim klijentima tog leta će doći notifikacija     o toj izmjeni
  - Dodavanje novih letova
  - Praćenje statistike svih letova
  - Dodavanje akcija, sniženja i posebnih ponuda

## Akteri :eight_pointed_black_star:
- **Posjetilac** - korisnik koji ima pristup osnovnim funkcionalnostima programa, tipa pregleda letova te trazenje istih (neregistrovan korisnik).
- **Registrovan korisnik** - ima pristup svim korisnickim funkcionalnostima.
    - **Pojedinac** - user profil namijenjen da ga koristi jedna osoba za licne potrebe.
        - **VIP član** - pojedinac koji je uclanjen u VIP program kompanije
    - **Agencija** - user profil namjenjen za partner-kompaniju
- **Uposlenik** - osobe koje rade za aviokompaniju, osobe za salterom
- **Supervizor** - ima zadatak ažuriranja sistema letova, karti, korisnika i obavještenja
- **Administrator** - upravlja i održava sistem
