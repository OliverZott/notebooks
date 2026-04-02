# Notebook Playground for C# and Python

## Setup

- Install dependencies

    ```shell
    # Create the env at repo root
    python -m venv .venv

    # Activate it
    .\.venv\Scripts\Activate.ps1
    py -m pip install --upgrade pip

    # Install Jupyter inside the env
    pip install jupyter ipykernel

    # Register it as a named kernel for VS Code / Jupyter
    python -m ipykernel install --user --name=notebooks-env --display-name "Python (notebooks)"

    # C# kernel (for classic Jupyter web client too)
    dotnet tool install -g Microsoft.dotnet-interactive
    dotnet interactive jupyter install
    ```

## Run / Debug

- Select respective kernels in notebooks
- **Python**: debug in notebook next to cells play button
- **C#**: debug current open file by using launch config with `F5`
