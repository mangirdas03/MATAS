# MATAS - Smart Energy Solutions
"MATAS" - tai projektas, skirtas padėti naudotojams sekti bei sumažinti energijos sąnaudas išmanių prietaisų pagalba.
Projektas susideda iš Tinklapio (.NET Core MVC bei MySQL) ir Elektros energijos matavimo įrenginio (naudojamas Arduino mikro kompiuteris).
![image](https://user-images.githubusercontent.com/79504320/168589484-cb60ab24-4c51-4616-951b-78df7ba50357.png)
![image](https://user-images.githubusercontent.com/79504320/168589564-ea63d160-300d-4a72-8b78-05daa16e50f7.png)
![image](https://user-images.githubusercontent.com/79504320/168589594-3436fbca-b62b-49e9-9613-c8678e127bc2.png)
![image](https://user-images.githubusercontent.com/79504320/168589716-b13f8819-ccc5-4579-9615-d027dd409dfe.png)


PhpMyAdmin MySQL debug settings: server=localhost; user=pvp; password=pvp; database=pvp;


Test site account:
Email: mangirdas@mail.com
Pass: pvpk053

Device setup strings:
OwCn0qs8IK - Vonia

4uPJgx4Exa - Garažas

ezpm7phFO9

hkOHSxqqa6

HTTP Requests that are sent from Arduino micro-computer:

To add electricity statistics data:
  (id - device setup code)
  POST: https://localhost:5001/api/wattage
  JSON format:
    {
      "wattage":100,
      "id":"OwCn0qs8IK"
    }

To add Real-Time electricity data:
(id - device setup code)
  POST: https://localhost:5001/api/livewattage
  JSON format:
    {
      "wattage":100,
      "id":"OwCn0qs8IK"
    }
    
Check current status
  GET https://localhost:5001/api/status/{id}
