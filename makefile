test:
	dotnet test /p:CollectCoverage=true \
		/p:CoverletOutputFormat=cobertura \
		/p:CoverletOutput=./TestResult/coverage.cobertura.xml
	dotnet reportgenerator \
		-reports:"./playground.UnitTest/TestResult/coverage.cobertura.xml" \
		-targetdir:"./playground.UnitTest/TestResult" \
		-reporttypes:Html
	open playground.UnitTest/TestResult/index.html

test2:
	dotnet test /p:CollectCoverage=true \
		/p:CoverletOutputFormat=cobertura \
		/p:CoverletOutput=./TestResult/coverage.cobertura.xml
	reportgenerator \
		-reports:"./playground.UnitTest/TestResult/coverage.cobertura.xml" \
		-targetdir:"./playground.UnitTest/TestResult" \
		-reporttypes:Html
	./playground.UnitTest/TestResult\index.html