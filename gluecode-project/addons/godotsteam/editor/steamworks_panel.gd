@tool
extends Control

@onready var container_frame: VBoxContainer = %ContainerFrame


func add_companion_dock(companion_dock: Control) -> void:
	container_frame.add_child(companion_dock)
