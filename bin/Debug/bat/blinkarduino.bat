@echo off
  

	
:: Get the Blink length set by the user in the Blinkit GUI, stored in \config\ and put it into variable %blinklengthsonoff%
	set /p blinklengthsonoff=<c:\blinkit\config\blinklengthsonoff.txt

:: send to Arduino over COM	

	


Writing to a Serial Port

PS> [System.IO.Ports.SerialPort]::getportnames()

COM3

PS> $port= new-Object System.IO.Ports.SerialPort COM3,9600,None,8,one

PS> $port.open()

PS> $port.WriteLine("Hello world")

PS> $port.Close()



timeout 10

:: Close the program	
	cls
	
	
	
	
	