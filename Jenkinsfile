pipeline {
    agent {
        docker { image 'mcr.microsoft.com/dotnet/sdk:9.0' }
    }
    environment {
        DOTNET_CLI_TELEMETRY_OPTOUT = '1'
    }
    stages {
        stage('Checkout') {
            steps {
                git branch: 'main', url: 'https://github.com/joaobarbosasoitic/DemoCICD', credentialsId: 'github-token'
            }
        }
        stage('Restore') {
            steps { sh 'dotnet restore' }
        }
        stage('Build') {
            steps { sh 'dotnet build -c Release' }
        }
        stage('Test') {
            steps { sh 'dotnet test -c Release --no-build' }
        }
    }
}
