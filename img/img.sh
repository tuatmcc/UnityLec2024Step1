#!/bin/bash

for file in *.png; do
  filename="${file%.*}"
  if [ -f "$filename.webp" ]; then
    continue
  fi
  convert "$file" "$filename.webp"
  echo "Converted $file to $filename.webp"
done