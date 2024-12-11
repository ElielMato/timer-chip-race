# Race Timing System with Programmed Chips

This project aims to create a race timing system to record the times of participants using programmed chips. The system is developed in **C#** and allows tracking the time each runner takes to complete a section of the race as they pass through a checkpoint with a programmed chip or similar device. In the future, this system could be integrated with chip readers to automate data collection.

## Project Status

🚧 **In Development** 🚧

## Features

- **Time Registration**: Records the time each participant takes to complete a race section.
- **Support for Multiple Runners**: Times are stored in a dictionary with the chip identifier as the key.
- **Real-time Timer**: Uses a stopwatch for accurate time measurement.
- **Future Integrations**: Designed for future expansion with chip readers and other devices.

## Functionality

- **Start Race**: The timer begins when the first chip is detected.
- **Stop Time**: The time stops when the participant's chip is detected at the finish line.
- **Store Times**: The times for each participant are stored along with their unique identifier (chip).
- **View Times**: Participant times can be viewed through the console.

## Technologies

- **C#**: The programming language used to develop the system.
- **.NET Core**: The framework used for building the console application.
- **Stopwatch**: A built-in C# class used for high-precision timing.
