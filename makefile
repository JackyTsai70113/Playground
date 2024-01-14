# cd <testProject> && dotnet add package coverlet.msbuild
#
# use these command to use dotnet reportgenerator:
# dotnet tool install -g dotnet-reportgenerator-globaltool
# dotnet tool install dotnet-reportgenerator-globaltool --tool-path tools
# dotnet new tool-manifest
# dotnet tool install dotnet-reportgenerator-globaltool
CC=gcc
shellName = $(shell uname)

test:
ifeq ($(shellName),Darwin)
	dotnet test /p:CollectCoverage=true /p:CoverletOutputFormat=cobertura /p:CoverletOutput=./TestResults/coverage.cobertura.xml
	dotnet reportgenerator -reports:"./playground.UnitTest/TestResults/coverage.cobertura.xml" -targetdir:"./playground.UnitTest/TestResults" -reporttypes:Html
else
	dotnet test /p:CollectCoverage=true \
		/p:CoverletOutputFormat=cobertura \
		/p:CoverletOutput=./TestResults/coverage.cobertura.xml
	reportgenerator -reports:"./playground.UnitTest/TestResults/coverage.cobertura.xml" -targetdir:"./playground.UnitTest/TestResults" -reporttypes:Html
endif

tresult:
ifeq ($(shellName),Darwin)
	open playground.UnitTest/TestResults/index.html
else
	start "playground.UnitTest/TestResults/index.html"
endif
