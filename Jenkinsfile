pipeline {
    agent any
    
    environment {
        UNITY_PATH = "C:\\Program Files\\Unity\\Hub\\Editor\\2022.3.9f1\\Editor\\Unity.exe" // CAMBIAD ESTO
        REPO_URL = "https://github.com/sokid93/CookieClickerJenkins.git"
    }
    
    stages {
        stage('Checkout') {
            steps {
                bat "git pull ${REPO_URL}"
            }
        }
        
        stage('Test') {
            steps {
                bat """
                    if not exist "CI" mkdir "CI"
                    "${UNITY_PATH}" -runTests -projectPath "%WORKSPACE%" -exit -batchmode -testResults "%WORKSPACE%\\CI\\results.xml" -testPlatform EditMode
                """
            }
        }
        
        stage('Build') {
            steps {
                bat """
                    "${UNITY_PATH}" -executeMethod BuildScript.Build -projectPath "%WORKSPACE%" -quit -batchmode -logFile "%WORKSPACE%\\CI\\unity.log"
                """
                archiveArtifacts artifacts: 'Build/**/*', fingerprint: true
            }
        }

	stage('Deploy') {
		steps {
			bat"""
				butler push "${pwd()}/Build" sokid93/test-jenkins:windows
			"""
		}
	}	
    }
    post {
        failure {
            discordSend description: "Something failed", footer: "Footer", link: env.BUILD_URL, result: currentBuild.currentResult, title: "[Fran]", webhookURL: "https://discord.com/api/webhooks/1406578895809155113/sG90X913cAPnqE00h_8B2n_jmD52pp9Z6oo6pmLkozhYS-RQwm3dzsjoO5XXd7iK0Tsm"
        }
        success {
            discordSend description: "Commit Stage ha ido bien", footer: "Haz click en el link para iniciar el despliegue en itch.io", link: "http://localhost:9090/job/PublishTest/build?delay=0sec", result: currentBuild.currentResult, title: "[Fran]", webhookURL: "https://discord.com/api/webhooks/1406578895809155113/sG90X913cAPnqE00h_8B2n_jmD52pp9Z6oo6pmLkozhYS-RQwm3dzsjoO5XXd7iK0Tsm"
        }
    }	
}