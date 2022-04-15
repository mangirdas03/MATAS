# PVP
Produkto vystymo projekto WEB IS

PhpMyAdmin MySQL settings: server=localhost; user=pvp; password=pvp; database=pvp;


Test site account:
Email: testas@test.com
Pass: 12345678


HTTP:

Add electricity data:
  POST: https://localhost:5001/api/wattage
  JSON format:
    {
      "wattage":100,
      "id":"qwertyu"
    }

Add Real-Time electricity data:
  POST: https://localhost:5001/api/livewattage
  JSON format:
    {
      "wattage":100,
      "id":"qwertyu"
    }
    
