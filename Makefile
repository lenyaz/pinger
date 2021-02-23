main.exe: main.cs
	mcs main.cs -r:System.Windows.Forms -r:System.Drawing
	
run: main.cs
	mcs main.cs -r:System.Windows.Forms -r:System.Drawing && mono main.exe 8.8.8.8
	
zip: main.cs
	mcs main.cs -r:System.Windows.Forms -r:System.Drawing && zip prog.zip main.exe ok.ico error.ico
