main.exe: main.cs
	mcs main.cs
	
run: main.cs
	mcs main.cs && mono main.exe 8.8.8.8
