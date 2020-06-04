### Hopfield Network

[![Build status](https://ci.appveyor.com/api/projects/status/ffq8cv5lwpon71ul?svg=true)](https://ci.appveyor.com/project/OlivierMounicq/HopfieldNetwork-DotNetCore) 
[![Tests Status](https://img.shields.io/appveyor/tests/OlivierMounicq/HopfieldNetwork-DotNetCore.svg?logo=appveyor)](https://ci.appveyor.com/project/OlivierMounicq/HopfieldNetwork-DotNetCore/build/tests) 
[![Coverage Status](https://coveralls.io/repos/github/OlivierMounicq/HopfieldNetwork-DotNetCore/badge.svg?branch=master)](https://coveralls.io/github/OlivierMounicq/HopfieldNetwork-DotNetCore?branch=master)

1/  Create a new folder by using the explorer  
2/  Launch Visual Studio Code  
3/  Open the folder HopfieldNetwork-DotnetCore  
4/  dotnet new sln (by using the terminal)  
5/  mkdir HopfieldNetwork  
6/  cd HopfieldNetwork  
7/  dotnet new classlib  
8/  cd ..  
9/  mkdir HopfieldNetworkTesting  
10/ cd HopfieldNetworkTesting  
11/ dotnet new mstest  
12/ dotnet add reference ../HopfieldNetwork/HopfieldNetwork.csproj  
13/	dotnet sln add ./HopfieldNetwork/HopfieldNetwork.csproj  
14/ dotnet sln add ./HopfieldNetworkTesting/HopfieldNetworkTesting.csproj	  
13/ dotnet build  
14/ dotnet test    
15/ git init  
16/ git add -all
17/ git commit -a -m "1st commit"  
18/ go github and create a new repository without readme   
19/ git remote add origin https://github.com/OlivierMounicq/HopfieldNetwork-DotNetCore.git  
20/ update the sln file by adding a project  		
21/ git commit -a -m "Add the testing project to the solution file"  
22/ git push origin master  
