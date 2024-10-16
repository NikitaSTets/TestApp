# Define the container name and MongoDB version
$containerName = "mongo_v2"
$mongoVersion = "latest"

# Check if the MongoDB container is already running
$runningContainer = docker ps -q -f name=$containerName

if ($runningContainer) {
    Write-Host "MongoDB container is already running."
} else {
    Write-Host "Starting MongoDB container..."
    
    # Run the MongoDB container
    docker run -d `
        --name $containerName `
        -p 27023:27017 `
        -v mongo_data:/data/db `
        mongo:$mongoVersion

    Write-Host "MongoDB is running on port 27023."
}
