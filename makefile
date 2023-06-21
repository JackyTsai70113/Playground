test:
	dotnet test /p:CollectCoverage=true \
		/p:CoverletOutputFormat=cobertura \
		/p:CoverletOutput=./TestResults/coverage.cobertura.xml
	dotnet reportgenerator \
		-reports:"./playground.UnitTest/TestResults/coverage.cobertura.xml" \
		-targetdir:"./playground.UnitTest/TestResults" \
		-reporttypes:Html

test-result:
	open playground.UnitTest/TestResults/index.html

test2:
	dotnet test /p:CollectCoverage=true \
		/p:CoverletOutputFormat=cobertura \
		/p:CoverletOutput=./TestResults/coverage.cobertura.xml
	reportgenerator \
		-reports:"./playground.UnitTest/TestResults/coverage.cobertura.xml" \
		-targetdir:"./playground.UnitTest/TestResults" \
		-reporttypes:Html

test-result2:
	start "playground/playground.UnitTest/TestResults/index.html"

test3:
	echo "$(shell uname)"
